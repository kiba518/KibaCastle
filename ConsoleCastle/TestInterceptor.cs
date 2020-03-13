using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCastle
{
    public class TestInterceptor
    {
        public virtual void MethodInterceptor()
        {
            Console.WriteLine("走过滤器");
        }

        public void NoInterceptor()
        {
            Console.WriteLine("没有走过滤器");
        }
    }
   
}
