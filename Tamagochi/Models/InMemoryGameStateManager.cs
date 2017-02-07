using System;
using System.Collections.Generic;
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
            get{ return _memento;}
            set{_memento = value;}
        }

        public void SaveStateOnHDD()
        {
            FileStream fout = null;
            byte[] stateValues = new[]{ (byte)Memento.TamagochiState.Health,
                                        (byte)Memento.TamagochiState.Age,
                                        (byte)Memento.TamagochiState.Bellyful,
                                        (byte)Memento.TamagochiState.Hapiness,
                                        (byte)Memento.TamagochiState.Intellect,
                                        (byte)Memento.TamagochiState.Water,
                                        (byte)Memento.Points
        };

            try
            {
                fout = new FileStream("savedGameState.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fout.Write(stateValues, 0, stateValues.Length);
                MessageBox.Show("Збережено на диск");
            }
            catch (IOException exc)
            {
                MessageBox.Show("IO Error" + exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                fout?.Close();
            }
        }

        public void LoadStateFromHdd()
        {
            FileStream fin = null;
            try
            {
                fin = new FileStream("savedGameState.txt", FileMode.Open, FileAccess.Read);
                _memento = new GameState();
                _memento.TamagochiState.Health = fin.ReadByte();
                _memento.TamagochiState.Age = fin.ReadByte();
                _memento.TamagochiState.Bellyful = fin.ReadByte();
                _memento.TamagochiState.Hapiness = fin.ReadByte();
                _memento.TamagochiState.Intellect = fin.ReadByte();
                _memento.TamagochiState.Water = fin.ReadByte();
                _memento.Points = fin.ReadByte();
                MessageBox.Show("Завантажено з диску");
            }
            catch (IOException exc)
            {
                MessageBox.Show("Помилка вводу виводу" + exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                fin?.Close();
            }

        }

    }
}
