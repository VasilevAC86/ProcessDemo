using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; // Для работы с классом Process (нечто, что в оперативной памяти)
using System.Diagnostics; // Для доступа к процессу без полного имени

namespace ProcessDemo
{
    public partial class Form1 : Form
    {
        Process _process; // Сcылка на процесс для далнейшей работы с процесссом
        //List<Process> _processes = new List<Process>(); // Список процессов, инцифлизируем,
                                                        // чтобы сразу обращаться к нему
        List<string> runProcess = new List<string>(); // Перед названием процесса кладём его id
        public Form1()
        {
            InitializeComponent();
        }

        private void RunProcess(string _path)
        {
            // StartInfo - путь, откуда мы берём исполняемый файл
            processDemo.StartInfo = new System.Diagnostics.ProcessStartInfo(_path); // ПЕредаём название процесса
            processDemo.Start(); // Запускаем процесс           
            int Id = processDemo.Id;
            string Name = processDemo.ProcessName;
            runProcess.Add($"{Id} \t{Name}");            
            lstBoxRunProcess.DataSource = runProcess; // Обновляем listBox (меняем datasource)
            lstBoxRunProcess.Refresh();
            List<string> _lstProc = new List<string>(); // Временный список всех процессов
            foreach (var proc in Process.GetProcesses())
            {
                _lstProc.Add($"{proc.Id} \t { proc.ProcessName}");
            }
            cmbAllProcess.DataSource = _lstProc;
            cmbAllProcess.Refresh();
        }
        private void CloseProcess(int _id) // метод завершения процесса, у каждого процесса в системе есть id
        {
            string tmp = string.Empty;
            foreach (var item in runProcess) // Process.GetProcesses() - список всех процессов в системе
            {
                tmp = item.Split(' ')[0]; // Берём только первый элемент масссива с инд. 0 (id)
                if (int.Parse(tmp) == _id) 
                {
                    _process = Process.GetProcessById(_id); // Возвращает процесс по id
                    _process.CloseMainWindow(); // Закрывает графический интерфейс процесса
                    _process.Close(); // Используя ссылку на процесс, закрываем его
                }                
            }            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunProcess(tbPath.Text);            
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss.fff"); // Раз в секунду обновляеи время на заголовке формы
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var tmp = lstBoxRunProcess.SelectedItem.ToString().Split(' ')[0];
            CloseProcess(int.Parse(tmp));
        }
    }
}
