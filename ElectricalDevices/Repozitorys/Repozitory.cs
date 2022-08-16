using ElectricalDevices.Repozitorys.Interface;
using ElectricalDevices.Models;

namespace ElectricalDevices.Repozitorys
{
    public class Repozitory : IRepozitory
    {
        public List<Devices> _device { get; set; }

        public Repozitory()
        {
            _device = new List<Devices>()
            {
                new Devices()
                {
                    Name = "Кофемолка",
                    Information = "приспособление для ручного, механического или электрического " +
                    "измельчения кофейных зёрен и других сыпучих продуктов (сахара, сухарей и т. п.)" +
                    " с помощью вращающихся жерновов, расстояние между которыми регулируется винтом"
                },
                 new Devices()
                {
                    Name = "Миксер",
                    Information = "устройство для приготовления пищи методом перемешивания её компонентов " +
                    "до создания однородной массы и обогащения взбиваемой жидкости воздухом. " +
                    "Миксером взбивают и замешивают яйца, сливки, коктейли, мусс, омлет, тесто, пюре, соусы и другие продукты."
                },
                  new Devices()
                {
                    Name = "Блендер",
                    Information = "это кухонный и лабораторный прибор, используемый для смешивания," +
                    " измельчения, пюре или эмульгирования пищевых и других веществ. Стационарный блендер состоит из " +
                    "контейнера блендера с вращающимся металлическим лезвием внизу, приводимого в действие электродвигателем, " +
                    "находящимся в основании."
                }


            };

        }

        public List<string> GetInformation()
        {
            List<string> info = new List<string>();

            foreach (var cocktail in _device)
            {
                info.Add(cocktail.Information);
            }
            return info;
        }

        public List<string> GetName()
        {
            List<string> name = new List<string>();

            foreach (var item in _device)
            {
                name.Add(item.Name);
            }
            return name;
        }

        public void SevaFile()
        {
            string path = "Test.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var item in _device)
                {
                    writer.WriteLine($"Name: {item.Name} Information: {item.Information}");
                }

            }
            Console.WriteLine("Запись в файл выполнена");
        }
    }
}
