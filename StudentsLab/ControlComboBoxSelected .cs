using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentsLab
{
    public partial class ControlComboBoxSelected : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;
        private string _selectedItem;       
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _comboBoxSelectedElementChange;
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < comboBox.Items.Count)
                {
                    _selectedIndex = value; 
                    comboBox.SelectedIndex = _selectedIndex;
                }
            }
        }    
        
        public void ChangeIndex()
        {
            Random rnd = new Random();
            comboBox.SelectedIndex = rnd.Next(0, comboBox.Items.Count);
        }
        

        public void addElement(string element)
        {
            comboBox.Items.Add(element);
        }
        
        /// <summary>
        /// Выбранный элемент
        /// </summary>
        [Category("Спецификация"), Description("Выбранный элемент")]
        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {               
                    _selectedItem = value; 
                    comboBox.SelectedItem = _selectedItem;               
            }
            
        }
        /// <summary>
        /// Текст выбранной записи
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return comboBox.Text; }
        }
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChange += value; }
            remove { _comboBoxSelectedElementChange -= value; }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public ControlComboBoxSelected()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => {
                _comboBoxSelectedElementChange?.Invoke(sender, e);
            };
        }  
        
        public void fillList()
        {
            addElement("Значение1");
            addElement("Значение2");
            addElement("Значение3");
            addElement("Значение4");
            addElement("Значение5");
        }      
    }

}
