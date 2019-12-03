using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace GraphDialog
{
    public partial class Form_Async : Form
    {
        private int timeTick = 0;
        public Form_Async()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTick += 1;
            label_TimeTick.Text = timeTick.ToString();
        }

        delegate void RevisionStatusDelegate(string msg);
        public void RevisionStatus(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new RevisionStatusDelegate(RevisionStatus), msg);
                return;
            }
            label_Status.Text = msg;
        }




        async Task Doing01()
        {
            Thread.Sleep(111);
        }

        async Task Doing02()
        {
            Thread.Sleep(222);
        }
        async Task Doing03()
        {
            Thread.Sleep(333);
        }

        //async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        //{
        //    var toast = await Doing01(number);
        //    Doing01(toast);
        //    Doing01(toast);
        //    return toast;
        //}
        static async Task<int> AsyncTest_basic()
        {
            var task = new Task<int>(() =>
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                    // 0.1초 단위로 1씩 증감
                    //Console.WriteLine(i);
                    Thread.Sleep(100);
                }
                return sum;
            });
            task.Start();
            //외부에서 await에서 기다린다.
            await task;
            // Wait가 호출되면 통과된다.
            Console.WriteLine(task.Result);
            return 10;
        }



        void TestR()
        {
            Debug.WriteLine("Start---TestR()");
            for (int i = 0; i < 500; i++)
            {
                string str = "TestR" + i.ToString();
                Debug.WriteLine(str);
                RevisionStatus(str);
                Thread.Sleep(10);
            }
            Debug.WriteLine("Finish---TestR()");
        }


        private void button_Start_Click(object sender, EventArgs e)
        {
            TestR();
        }

        private async void button_AsyncStart_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Start--async-TestR()");
            Task testTask = Task.Run(() => TestR()); //Task.Factory.StartNew
            await testTask;

            Task testTask2 = Task.Run(() => TestR());
            await testTask2;

            Task testTask3 = Task.Run(() => TestR());
            await testTask3;
            //testTask3.Wait();

            Debug.WriteLine("Finish--async-TestR()");
            label_Status.Text += "       Finish--async-TestR()";
        }

        private async void button_AsyncStart2nd_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Start--button_AsyncStart2nd_Click");
            Task<int> testTask = Task<int>.Run(() => AsyncTest()); //Task.Factory.StartNew


            for (int i = 0; i < 90; i++)
            {
                Console.WriteLine("#####");
                Thread.Sleep(100);
            }

            await testTask;
            Debug.WriteLine("Finish--async2-AsyncTest()");

            label_Status.Text = testTask.Result.ToString();
            label_Status.Text += "       Finish--async2-AsyncTest()";
        }


        void ThreadTest()
        {

            while(true)
            {
                var task = AsyncTest();
            }
                
        }
        async Task<int> AsyncTest()
        {
            Debug.WriteLine("Start -AsyncTest()");
            var task = new Task<int>(() =>
            //Task.Factory.StartNew
            {
                Debug.WriteLine("Start -AsyncTest().first");
                int sum = 0;
                for (int i = 0; i < 50; i++)
                {
                    sum += i;
                    // 0.1초 단위로 1씩 증감
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
                return sum; //55
            });
            task.Start();
            Debug.WriteLine("befor await");
            //await task;
            //Debug.WriteLine("after await");
            task = new Task<int>(() =>
            {
                Debug.WriteLine("Start -AsyncTest().Second");
                int sum = 0;
                for (int i = 200; i < 250; i++)
                {
                    sum += i;
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
                return sum; //29*5 =145
            });
            task.Start();
            // await이 위에 있지만 결국에는 145가 리턴된다.
            Debug.WriteLine("Finish -AsyncTest()");
            return task.Result;
        }//출처: https://nowonbun.tistory.com/419 [명월 일지]




        //var continueTask = AsyncTest().ContinueWith(task =>
        //{
        //    return task.Result;
        //});
        //ContinueWith 함수는 Task를 연달아 붙여서 사용할 때 사용합니다.
        //이 뜻은 Task => Wait => Result => Task => Wait => Result 이지만 
        //위처럼 ContinueWith함수를 써서 간단하게 처리를 했습니다.
        //ContinueWith는 C#의 콜백 함수라고도 부르는 사람도 있습니다.
        //출처: https://nowonbun.tistory.com/419 [명월 일지]
        //Task.WhenAll 메서드 또는 인스턴스 TaskFactory.ContinueWhenAll 메
        //Task.WhenAny 메서드 또는 인스턴스 TaskFactory.ContinueWhenAny 메
    }
}
