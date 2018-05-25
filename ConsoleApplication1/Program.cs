using ConsoleApplication1.AbstractFactory;
using ConsoleApplication1.Asynchronous;
using ConsoleApplication1.Asynchronous2;
using ConsoleApplication1.Dynamic;
using ConsoleApplication1.Events;
using ConsoleApplication1.OctopusDeploy;
using ConsoleApplication1.SqlBulkCopy;
using ConsoleApplication1.StronglyTypeIEnumerable;
using ConsoleApplication1.Structs;
using ConsoleApplication1.StructureMapAddAllTypesOf;
using ConsoleApplication1.StructureMapConstructorInjection;
using ConsoleApplication1.StructureMapProfiles;
using ConsoleApplication1.TemplatePattern;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        #region Blu-ray Read
        /*
        static void Main(string[] args)
        {
            string error = string.Empty;

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            //cmdStartInfo.CreateNoWindow = false;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.FileName = @"C:\exe\eac3to\eac3to.exe";
            cmdStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //cmdStartInfo.Arguments = @"""C:\temp\My Torrent Downloads\War.Pigs.2015.COMPLETE.BLURAY""";
            cmdStartInfo.Arguments = @"""\\KENSHIRO\My Torrent Encodes\Blu-ray\DISC\ARN_D1-BluHD""";
            
            cmdStartInfo.CreateNoWindow = true;
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;

            Process process = Process.Start(cmdStartInfo);
            using (StreamReader streamReader = process.StandardOutput)
            {
                int i = 1;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                    i++;
                }
            }

            using (StreamReader streamReader = process.StandardError)
            {
                error = streamReader.ReadToEnd();
            }


            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine("The following error was detected:");
                Console.WriteLine(error);
            }

            Console.Read();
        }
        */
        #endregion

        #region Substring
        /*
        static void Main(string[] args)
        {
            string file = "the eyes of texas are upon you.txt";

            string ext = file.Substring(file.Length - 4, 4);

            Console.WriteLine(ext);
            Console.Read();
        }
        */
        #endregion

        #region Linq Group By
        /*
        static void Main(string[] args)
        {
            string[] files = new string[] { "encode01", "encode02", "encode03", "encode02"};

            int countUnique = files.GroupBy(f => f).Count();

            Console.WriteLine(countUnique.ToString());
            Console.Read();
        }
        */
        #endregion

        #region Replace Double Quotes
        /*
        static void Main(string[] args)
        {
            string fileName = "Game   of  Thrones 2003 S02E01  1080p  Remux  AVC  TrueHD  -EbP .mkv";

            string myString = Regex.Replace(fileName, @"\s+", " ");

            Console.WriteLine(myString);
            Console.Read();
        }
        */
        #endregion

        #region Yield Return
        /*
        static void Main(string[] args)
        {
            //
            // Compute two with the exponent of 30.
            //
            foreach (int value in ComputePower(2, 30))
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.ReadLine();
        }

        public static IEnumerable<int> ComputePower(int number, int exponent)
        {
            int exponentNum = 0;
            int numberResult = 1;
            //
            // Continue loop until the exponent count is reached.
            //
            while (exponentNum < exponent)
            {
                //
                // Multiply the result.
                //
                numberResult *= number;
                exponentNum++;
                //
                // Return the result with yield.
                //
                yield return numberResult;
            }
        }
        */
        #endregion

        #region Dynamic Object
        /*
        static void Main(string[] args)
        {
            dynamic e = new Employee();

            e.FirstName = "Tom";
            e.LastName = "Jerry";
            e.BirthDate = new DateTime(1960, 12, 01);
 
            Func<string, string, string> method = (a, b) => a + " " + b;
 
            e.GetData = method;
            Console.WriteLine(e.FirstName + " " + e.LastName + "..." + e.GetData("Tom", "Jerry"));

            Console.ReadLine();
        }
        */
        #endregion

        #region StructureMap Profiles
        /*
        static void Main(string[] args)
        {
            IoC.Init();
            var container = IoC.MyContainer;
            var nestedContainer = container.GetNestedContainer();

            Console.WriteLine(string.Format("The ID for Main Container Object1 is: {0}", container.GetInstance<IBreadCrumbPath>().Id.ToString()));
            Console.WriteLine(string.Format("The ID for Main Container Object2 is: {0}", container.GetInstance<IBreadCrumbPath>().Id.ToString()));


            var profile = container.GetProfile("profile2");
            var breadCrumb1 = profile.GetInstance<IBreadCrumbPath>();
            Console.WriteLine(string.Format("The ID for profile2 Object1 is: {0} and it is a {1}.", breadCrumb1.Id.ToString(),breadCrumb1.IAmA()));

            profile = container.GetProfile("profile1");
            var breadCrumb2 = profile.GetInstance<IBreadCrumbPath>();
            Console.WriteLine(string.Format("The ID for profile1 Object1 is: {0} and it is a {1}.", breadCrumb2.Id.ToString(), breadCrumb1.IAmA()));

            Console.WriteLine("Nested Containder....");

            profile = nestedContainer.GetProfile("profile2");
            var breadCrumb3 = nestedContainer.GetInstance<IBreadCrumbPath>();
            var breadCrumb4 = nestedContainer.GetInstance<IBreadCrumbPath>();
            Console.WriteLine(string.Format("The ID for profile2 Object1 is: {0} and it is a {1}.", breadCrumb3.Id.ToString(), breadCrumb3.IAmA()));
            Console.WriteLine(string.Format("The ID for profile2 Object1 is: {0} and it is a {1}.", breadCrumb4.Id.ToString(), breadCrumb4.IAmA()));

            Console.ReadLine();
        }
         */
        #endregion

        #region StronglyType IEnumerable
        /*
        static void Main(string[] args)
        {
            string entityKeyPair = "AuditType|Complex";
            Breadcrumb breadcrumb = new Breadcrumb(entityKeyPair);

            foreach (var item in breadcrumb)
            {
                Console.WriteLine(item.Entity);
            }

            Console.ReadLine();
        }
        */
        #endregion

        #region Template Pattern
        /*
        static void Main(string[] args)
        {
            var templates = new List<TemplatePatternBase>() { new TheGameOAging(), new TheGameOfSimpletons() };


            foreach (var template in templates)
            {
                Console.WriteLine(template.TemplateMethod());
            }

            Console.ReadLine();
        }
        */
        #endregion

        #region Abstract Factory Pattern
        /*
        static void Main(string[] args)
        {
            AbstractSodaFactory sodaFactory = new SodaFactory();
            List<IProduct> products = new List<IProduct>();

            //coke
            AbstractProductFactory cokeFactory = new CokeProductFactory();
            IProduct cokeProduct = cokeFactory.NewSoda();
            products.Add(cokeProduct);

            //pepsi
            AbstractProductFactory pepsiFactory = new PepsiProductFactory();
            IProduct pepsiProduct = pepsiFactory.NewSoda();
            products.Add(pepsiProduct);

            //sprite
            AbstractProductFactory spriteFactory = new SpriteProductFactory();
            IProduct spriteProduct = spriteFactory.NewSoda();
            products.Add(spriteProduct);

            foreach (var product in products)
            {
                Console.WriteLine(string.Format("Product Name is: {0}",product.GetName()));
            }

            Console.ReadLine();
        }
        */
        #endregion

        #region Events
        /*
        static void Main(string[] args)
        {
            IStockBrokerManager manager = new StockBrokerManager("Michael");

            //broker 1
            IStockBroker broker1 = new StockBroker("Jake");
            broker1.StockTraded += manager.StockTradedHandler;

            //broker 2
            IStockBroker broker2 = new StockBroker("Jill");
            broker2.StockTraded += manager.StockTradedHandler;

            broker2.TradeStock("IBM");
            broker1.TradeStock("MSFT");
            broker1.TradeStock("Apple");

            Console.ReadLine();
        }
        */
        #endregion

        #region Dictionaries
        /*
    static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "Test");
        dictionary.Add(1, "Test");

        Console.ReadLine();
    }
    */
        #endregion

        #region StructureMap Constructor Injection
        /*        
        static void Main(string[] args)
        {
            StructureMapConstructorInjectionIoC.Init();
            var container = StructureMapConstructorInjectionIoC.MyContainer;
            var nestedContainer = container.GetNestedContainer();

            var constructor = nestedContainer.TryGetInstance<IConstructor>();

            Console.WriteLine(constructor.GetIdentifier());

            Console.ReadLine();
        }
         */
        #endregion

        #region Milliseconds to Hours
        /*
        static void Main(string[] args)
        {
            string settingInMilliseconds = "3600000";

            double milliseconds = Convert.ToDouble(settingInMilliseconds);

            double hours = TimeSpan.FromMilliseconds(milliseconds).TotalMinutes;

            Console.WriteLine(string.Format("Hours are: {0}", hours.ToString()));

            Console.ReadLine();


        }
        */
        #endregion

        #region Asynchronous
        /*
        static void Main(string[] args)
        {

            LongRunningAsyncService service = new LongRunningAsyncService();

            var task1 = service.WhatIsMyName();
            task1.ContinueWith(x => PrintName(x.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            task1.ContinueWith(y => Console.WriteLine("An exception was thrown in task1"), TaskContinuationOptions.OnlyOnFaulted);
                        
            var task2 = service.WhatIsMyNameException();
            task2.ContinueWith(x => PrintName(x.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            task2.ContinueWith(x => Console.WriteLine("An exception was thrown in task2"), TaskContinuationOptions.OnlyOnFaulted);
            
            Console.WriteLine("Continuing after the Async call is made.  We will update you when we are done getting the name....");

            Console.ReadLine();
        }

        private static void PrintName(string name)
        {
            Console.WriteLine(string.Format("The name is: {0}.",name));
        }
        */
        #endregion

        #region Date Difference
        /*static void Main(string[] args)
        {

            DateTime currentDate = DateTime.Now;
            DateTime? endDate = DateTime.Now.AddDays(45);

            var span = (endDate - currentDate);
            Console.WriteLine(string.Format("Difference is: {0}",span.Value.Days));

            Console.ReadLine();
        }*/
        #endregion

        #region Decimal Rounding
        /*
        static void Main(string[] args)
        {

            decimal? one = 23.005m;
            decimal? two = 23.0051m;

            Console.WriteLine(string.Format("{0}, {1}",one.Value.ToString("p"), two.Value.ToString("p")));

            Console.ReadLine();
        }
        */
        #endregion

        #region StructureMap AllKnownTypesOf
        /*static void Main(string[] args)
        {
            //Only look at the classes in the StructureMapAddAllTypesOf Folder
            StructureMapAddAllTypesOfIoC.Init(); //register StructureMap
            var container = StructureMapAddAllTypesOfIoC.MyContainer; //get the StructureMap container
            IDoSomethingService doSomethingService = container.GetInstance<IDoSomethingService>(); //grab the DoSomethingService, remember, StructureMap is smart so it will automatically look for a DoSomethingService when a IDoSomethingService is requested as a convention
            doSomethingService.Do(); //call Do method

            Console.ReadLine();
        }*/
        #endregion

        #region Asynchronous2
        /*static async Task Main(string[] args)
        {
            Console.WriteLine($"Current Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            AsynchronousService2 service = new AsynchronousService2();

            var task1 = await service.CalculateTaskRunAsync(1, 8000000);
            var task2 = await service.CalculateAsync(1, 8000000);
            

            Console.ReadLine();
        }*/
        #endregion

        #region Abstract Class Testing
        /*static async Task Main(string[] args)
        {
            Console.WriteLine($"Current Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            AsynchronousService2 service = new AsynchronousService2();

            var task1 = await service.CalculateTaskRunAsync(1, 8000000);
            var task2 = await service.CalculateAsync(1, 8000000);


            Console.ReadLine();
        }*/
        #endregion

        #region Structs
        /*static async Task Main(string[] args)
        {
            Console.WriteLine($"Value for Co-Applicant is: {SystemConstants.CreditApplicantTypeId.CoApplicant}");


            Console.ReadLine();
        }*/
        #endregion

        #region Sql Bulk Copy
        /*static async Task Main(string[] args)
        {

            //Usage
            IList<LoanApplication> loanApplications = new List<LoanApplication>() { new LoanApplication() { ApplicationId = 1, CreatedDate = DateTime.Now, FirstName = "Michael", LastName = "Green" },
            new LoanApplication() { ApplicationId = 2, CreatedDate = DateTime.Now, FirstName = "Amy", LastName = "Green" }};

            if (loanApplications != null && loanApplications.Count()  > 0)
            {
                SqlBulkCopyConfiguration config = new SqlBulkCopyConfiguration()
                {
                    BatchSize = 100,
                    ConnectionString = "DatabaseConnectionString",
                    DataTable = ListExtensions.AsDataTable<LoanApplication>(loanApplications),
                    TableName = "dbo.SomeTableToInsertRecords"
                };
                new SqlBulkCopyService().Save(config);
            }

            Console.ReadLine();
        }*/
        #endregion

        #region Octopus Deploy
        /*static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["ConsoleApplication1FilePath"];

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            IList<Movie> movies = new List<Movie>() { new Movie() { Name = "Black Panther", ReleaseDate = DateTime.Now  }, new Movie() { Name = "Batman", ReleaseDate  = DateTime.Now } };
            FileService fileService = new FileService();
            for (int i = 1; i <= 5; i++)
            {
                string filePath = $@"{path}\{Guid.NewGuid()}.json";
                fileService.CreateFile(filePath, movies);
            }
       }*/
        #endregion

        #region Testing 123
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }*/
        #endregion

        #region Testing 12345
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Hahahaha!");
			Console.WriteLine("Hello World Hahahaha10101010!");
			Console.WriteLine("Hello World Hahahaha99999!");

            Console.ReadLine();
        }
        #endregion

    }
}
