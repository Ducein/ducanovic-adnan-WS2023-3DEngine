using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.WinForms;

namespace Übung
{
    internal class GameObject:TreeNode
    {
        private List<UserControl> componentList;

        public GameObject(string name)
        {
            Text = name;
            componentList = new List<UserControl>();
        }

        public void AddComponent(UserControl component)
        {
            componentList.Add(component);
        }

        public List<UserControl> GetComponents()
        {
            return componentList;
        }
    }

    public class NameComponent : UserControl
    {
        private TextBox textBox;

        public NameComponent(string initialName)
        {
            textBox = new TextBox();
            textBox.Text = initialName;
            Controls.Add(textBox);
        }

        public string GetName()
        {
            return textBox.Text;
        }

        public void SetName(string newName)
        {
            textBox.Text = newName;
        }
    }

    // Beispiel für eine OpenTK-Komponente
    public class GameComponent : GLControl
    {
        public GameComponent()
        {
            // Konfiguriere OpenTK-GLControl nach Bedarf
        }
    }

    public class ComponentManager : Form
    {
        public void DisplayComponents(List<UserControl> components)
        {
            // Implementiere Logik zum Anzeigen der Komponenten im rechten Teil der Hauptform
        }
    }
}
