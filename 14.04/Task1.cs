using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Green
{
    public class Task1 : Green
    {

        private int _output;
        public int Output => _output;


        public Task1(string input) : base(input)
        {
            _output = 0;
            //_output = default(int);

        }

        public override void Review()
        {
            int count = 0;
            // обработка текста
            // текст в input не меняется
            count += 1;

            // по результатам output должен возвращать правильный ответ 
            // для текста Input
            _output = count;
            
            
        }
        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{Output}";

        }




    }
}
