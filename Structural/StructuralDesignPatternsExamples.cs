using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Adapter.Adapter_No_Cashing;
using Design_Patterns.Structural.Adapter.DI_Adapter;
using Design_Patterns.Structural.Adapter.Generic_Value_Adapter;
using Design_Patterns.Structural.Bridge;
using Design_Patterns.Structural.Composite;
using Design_Patterns.Structural.Decorator;
using Design_Patterns.Structural.Facade;
using Design_Patterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Features.Metadata;
using Design_Patterns.Structural.Bridge.Bridge_BookExample;

namespace Design_Patterns.Structural
{
    public class StructuralDesignPatternsExamples
    {
        public void Run_Decorator_Example()
        {

            Console.WriteLine("Decorator pattern demo");
            MarutiCar mCar = new MarutiCar();
            Console.WriteLine("{0} {1} Regular price: {2}", mCar.GetBrand(), mCar.GetModel(), mCar.GetPrice());



            //Diwali Offer   
            DiwaliOffer dOffer = new DiwaliOffer(mCar);
            Console.WriteLine("{0} {1} Diwali price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), dOffer.NewPrice(), dOffer.PercentDiscount);



            //Holi Offer   
            HoliOffer hOffer = new HoliOffer(mCar);
            Console.WriteLine("{0} {1} Holi price: {2} after discount of {3} percent", mCar.GetBrand(), mCar.GetModel(), hOffer.NewPrice(), hOffer.PercentDiscount);

        }

        public void Run_Bridge_Example()
        {
            Console.WriteLine("Bridge pattern demo");

            IEmailSender webService = new WebServiceEmailSender();
            IEmailSender wcf = new WCFEmailSender();
            IEmailSender webApi = new WebAPIEmailSender();


            //System Email 
            Email email = new SystemEmail();
            email.Subject = "Test Message";
            email.Body = "Hi there, This is a Test Message from System";


            // ----------------------------------------------------------------------
            email.MessageSender = webService;
            email.Send();


            email.MessageSender = wcf;
            email.Send();


            email.MessageSender = webApi;
            email.Send();


            // User Email ---------------------------------------------------------- 

            email = new UserEmail();
            email.Subject = "Test Message";
            email.Body = "Hi there, This is a Test Message from Prakash";

            email.MessageSender = webApi;
            email.Send();


            email.MessageSender = wcf;
            email.Send();


            email.MessageSender = webApi;
            email.Send();

        }

        public void Run_Facade_Example()
        {
            Console.WriteLine("Facade pattern demo");
            var body = new Body();
            var engine = new Engine();
            var tyre = new Tyre();
            var accessories = new Accessories();
            CarFacade carFacade = new CarFacade(body , engine , tyre , accessories );
            carFacade.AssembleCar();
        }

        public void Run_Proxy_Exampple()
        {
            Console.WriteLine("Proxy pattern demo");
            IFilesService filesService = new FilesServicesProxy();
            filesService.WritePersonInFile("c:\\myfakepath\\a.txt", "Fazel", "Saeedi", 26);

            var directory = filesService.GetDirectoryInfo("d:\\myrightpath\\");
            var fileName = Path.Combine(directory.FullName, "dotnettips.txt");

            filesService.WritePersonInFile(fileName, "fa", "Saeedi", 26);
            filesService.WritePersonInFile(fileName, "Fazel", "Saeedi", 12);
            filesService.WritePersonInFile(fileName, "Fazel", "Saeedi", 26);

            filesService.DeleteFile("c:\\myfakefile.txt");
            filesService.DeleteFile(fileName);
        }
        
        public void Run_Adapter_Example()
        {
            Console.WriteLine("Adapter pattern demo");
            EmployeeDao dao = new EmployeeDao();


            // dao.save(new Employee()); // it is true but in OOP DTo should be seperate Entity
            //dao.save(EmployeeDto()); // Error


            var employeeDto = new EmployeeDto();
            employeeDto.id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
            employeeDto.firstName = "Fazel";
            employeeDto.lastName = "Saeedi";
            employeeDto.code = "4585-3252";

            dao.save(new EmployeeDtoAdapter(employeeDto));

        }

        public void Run_Composite_Example()
        {
            CEmployee Rahul = new CEmployee { EmpID = 1, Name = "Rahul" };

            CEmployee Amit = new CEmployee { EmpID = 2, Name = "Amit" };
            CEmployee Mohan = new CEmployee { EmpID = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            CEmployee Rita = new CEmployee { EmpID = 4, Name = "Rita" };
            CEmployee Hari = new CEmployee { EmpID = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            CEmployee Kamal = new CEmployee { EmpID = 6, Name = "Kamal" };
            CEmployee Raj = new CEmployee { EmpID = 7, Name = "Raj" };

            Contractor Sam = new Contractor { EmpID = 8, Name = "Sam" };
            Contractor tim = new Contractor { EmpID = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmpID, Rahul.Name);

            foreach (CEmployee manager in Rahul)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);
                
                 // foreach (CEmployee employee in manager)
                 // {
                 //     Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                 // }
            }
            Console.ReadKey();
        }
    
        // the interface we have
        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        public void Run_Adapter_No_Cashing_Example()
        {
            Draw();
            Draw();
        }
        private static void Draw()
        {
            List<VectorObject> vectorObjects = new List<VectorObject>
           {
               new VectorRectangle(1, 1, 10, 10),
               new VectorRectangle(3, 3, 6, 6)
           };

            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ToList().ForEach(DrawPoint);
                }
            }
        }
   

        public void Run_Generic_value_Adapter()
        {
            var v = new Vector2i(1, 2);
             v[0] = 0;
      
             var vv = new Vector2i(3, 2);

             var result = v + vv;

             Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
        }

        public void Run_Dependency_Injection_Adapter_Example()
        {
            // for each ICommand, a ToolbarButton is created to wrap it, and all
            // are passed to the editor
            var b = new ContainerBuilder();
            b.RegisterType<OpenCommand>()
                .As<ICommand>()
                .WithMetadata("Name", "Open");
            b.RegisterType<SaveCommand>()
                .As<ICommand>()
                .WithMetadata("Name", "Save");
            //b.RegisterType<Button>();
            b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd, ""));
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string)cmd.Metadata["Name"]));
            b.RegisterType<Editor>();
            using (var c = b.Build())
            {
                var editor = c.Resolve<Editor>();
                editor.ClickAll();

                // problem: only one button

                foreach (var btn in editor.Buttons)
                btn.PrintMe();
            }

        }

        public void Run_Bridge_Book_Example()
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle1 = new Circle(raster, 5);
            circle1.Draw();
            circle1.Resize(2);
            circle1.Draw();

            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(),
                p.Positional<float>(0)));
            using (var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(
                new PositionalParameter(0, 5.0f)
                );
                circle.Draw();
                circle.Resize(2);
                circle.Draw();
            }
        }
    }
}
