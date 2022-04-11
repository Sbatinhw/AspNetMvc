using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroPull
{
    public class CustomPull
    {
        private readonly int maxValue;
        private readonly Thread[] threads;
        private readonly Queue<Action> actions;
        private bool isWork;
        public CustomPull(int maxValue)
        {
            this.maxValue = maxValue;
            threads = new Thread[maxValue];
            actions = new Queue<Action>();
            Init();
        }
        //добавление в массив потоков
        private void Init()
        {
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Work);
            }
        }
        //запуск потоков
        public void Run()
        {
            isWork = true;
            foreach(var thread in threads)
            {
                thread.Start();
            }
        }
        //попытка остановить
        public void TryStop()
        {
            isWork = false;
        }
        //добавить задания на выполнение
        private void AddAction(Action item)
        {
            actions.Enqueue(item);
        }
        //выполнение заданий
        private void Work()
        {
            while (isWork)
            {
                Action action;
                lock (actions)
                {
                    action = actions.Dequeue();
                }
                action();
            }
        }
    }
}
