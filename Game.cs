using System.Windows.Forms;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class Game
    {
        public static void EndGame()
        {
            Settings.IsOver = true;            
            Task.Delay(1500);
            MessageBox.Show("Koniec Gry!\nTwój wynik to " + Settings.Score + " punktów!\n");
            Application.Exit();
        }
    }
}