using System.Windows;

namespace Lec17_CustomClassExample
{
    public class Example
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public Example()
        {
            FirstName = "John";
            Lastname = "Wick";
        }

        public void SayHello()
        {
            MessageBox.Show("Hello");
        }

        public override string ToString()
        {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(Lastname)}: {Lastname}";
        }
    }
}
