using System.Xml.Serialization;
namespace XMLSerialization
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var ser = new XmlSerializer(typeof(TestClassDTO));
            //конструктор без параметров
            //public class
            //свойсва с public setter

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "test.xml");

            //Serialization

            TestClass tst = new TestClass("test1", 1);
            tst.Add("smth1");
            tst.Add("smth2");
            tst.Add("smth3");
            TestClassDTO tstDTO = new TestClassDTO(tst.String, tst.Integer, tst.Strings);
            using (var writer = new StreamWriter(filePath))
            {
                ser.Serialize(writer, tstDTO);
            }
            //DeSerialization

            TestClassDTO tstDTO2;
            using (var reader = new StreamReader(filePath))
            {
                tstDTO2 = (TestClassDTO)ser.Deserialize(reader);
            }
            TestClass tst2 = new TestClass(tstDTO2.String, tstDTO2.Integer);

            foreach (var item in tstDTO2.Strings)
            {
                tst2.Add(item);
            }
            
            Console.WriteLine(tstDTO2.String == tst.String);
            Console.WriteLine(tstDTO2.Integer == tst.Integer);
       
            Console.WriteLine(Compeare(tst2, tst));
        }
        public static bool Compeare(TestClass t1, TestClass t2)
        {
            if (t1.Integer != t2.Integer) return false;
            if (t1.String != t2.String) return false;
            if (t1.Strings.Length != t2.Strings.Length) return false;
            else
            {
                for (int i = 0; i < t1.Strings.Length; i++)
                {
                    if (t1.Strings[i] != t2.Strings[i]) return false;
                }
            }
            return true;
            //else return true;
        }

       
    }
    public class TestClass
    {
        private int _integer;
        public int Integer => _integer;

        private string _string;
        public string String => _string;

        private string[] _strings;
        public string[] Strings => _strings;

        //public TestClass()
        //{
        //    _integer = 1;
        //    _string = "test";
        //}
        public TestClass(string string1, int integer1)
        {
            _integer = integer1;
            _string = string1;
            _strings = new string[0];

        }
        public void Add(string smth)
        {
            Array.Resize(ref _strings, _strings.Length + 1);
            _strings[_strings.Length - 1] = smth;

        }
    }
    public class TestClassDTO
    {
        public int Integer { get; set; }
        public string String { get; set; }
        public string[] Strings { get; set; }
        public TestClassDTO() { }
        public TestClassDTO(string string1, int integer1, string[] strings)
        {
            Integer = integer1;
            String = string1;
            Strings = strings;
        }
    }
}
