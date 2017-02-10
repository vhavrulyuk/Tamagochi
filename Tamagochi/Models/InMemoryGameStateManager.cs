using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tamagochi.Models
{
    class InMemoryGameStateManager
    {
        private GameState _memento;
        public GameState Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }

        public void SaveStateOnHDD()
        {
            StreamWriter fstr_out = null;
            string stateString = Memento.TamagochiState.Health.ToString() + "," +
                                 Memento.TamagochiState.Age.ToString() + "," +
                                 Memento.TamagochiState.Bellyful.ToString() + "," +
                                 Memento.TamagochiState.Hapiness.ToString() + "," +
                                 Memento.TamagochiState.Intellect.ToString() + "," +
                                 Memento.TamagochiState.Water.ToString() + "," +
                                 Memento.TamagochiState.Name + "," +
                                 Memento.TamagochiState.TamagochiType + "," +
                                 Memento.Points;
            try
            {
                fstr_out = new StreamWriter("savedGameState.txt");
                fstr_out.Write(stateString);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fstr_out?.Close();
            }
        }

        public void LoadStateFromHdd()
        {
            StreamReader fstr_in = null;
            string stateString;
            try
            {
                fstr_in = new StreamReader("savedGameState.txt");
                stateString = fstr_in.ReadLine();
                string[] stateArray = stateString?.Split(',');
                foreach (var str in stateArray)
                {
                    Debug.WriteLine(str);
                }
                _memento = new GameState();
                _memento.TamagochiState.Health = Int32.Parse(stateArray[0]);
                _memento.TamagochiState.Age = Int32.Parse(stateArray[1]);
                _memento.TamagochiState.Bellyful = Int32.Parse(stateArray[2]);
                _memento.TamagochiState.Hapiness = Int32.Parse(stateArray[3]);
                _memento.TamagochiState.Intellect = Int32.Parse(stateArray[4]);
                _memento.TamagochiState.Water = Int32.Parse(stateArray[5]);
                _memento.TamagochiState.Name = stateArray[6];
                _memento.TamagochiState.TamagochiType = stateArray[7];
                _memento.Points = Int32.Parse(stateArray[8]);
                MessageBox.Show("Завантажено з диску");
            }
            catch (IOException exc)
            {
                MessageBox.Show("Помилка відкриття файлу" + exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                fstr_in?.Close();
            }

        }

    }
}
