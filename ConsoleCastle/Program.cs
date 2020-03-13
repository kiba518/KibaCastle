using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCastle
{
    /*拦截器 Castle.Core*/
    class Program
    {
        static void Main(string[] args)
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】  
            Interceptor interceptor = new Interceptor();//实例化【拦截器】  

            //使用【代理类生成器】创建Person对象，而不是使用new关键字来实例化  
            TestInterceptor test = generator.CreateClassProxy<TestInterceptor>(interceptor);
            Console.WriteLine("当前类型:{0},父类型:{1}", test.GetType(), test.GetType().BaseType);
            Console.WriteLine();
            test.MethodInterceptor();
            Console.WriteLine();
            test.NoInterceptor();
            Console.WriteLine();
            Console.ReadLine();
        }
		 

	}
}
