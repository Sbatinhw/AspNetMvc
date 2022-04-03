using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MultiThreadWpf
{
    public class ThreadAddFib
    {
        TextBox textBoxFib;
        FibCalc fc;
        Slider sleepSlider;
        public ThreadAddFib(TextBox textBox, Slider sleepSlider)
        {
            this.textBoxFib = textBox;
            fc = new FibCalc();
            this.sleepSlider = sleepSlider;
        }
        public async void AddFib()
        {
            await Calc();
        }
        private async Task Calc()
        {
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    int wait = 0;
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        textBoxFib.Text = textBoxFib.Text + " " + fc.GetNum();
                        wait = (int)sleepSlider.Value;
                    });

                    Thread.Sleep(wait);
                }
            });
        }
    }
}
