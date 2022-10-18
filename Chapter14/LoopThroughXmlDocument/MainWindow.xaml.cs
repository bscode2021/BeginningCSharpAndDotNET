using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LoopThroughXmlDocument
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLoop_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\Srezovski\OneDrive\CA\Repositories\BSCode\BeginningCSharpAndDotNET\Chapter15\XML and Schemas\GhostStories.xml");
            textBlockResults.Text = FormatText(document.DocumentElement as XmlNode, "", "");
        }

        private string FormatText(XmlNode? node, string text, string indent)
        {
            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }
            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
            {
                text += "\r\n" + indent;
            }
            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }
            text += "<" + node.Name;
            if (node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }
            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + "   ");
                }
                if (node.ChildNodes.Count == 1 &&
                (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += "/>";
            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }
    }
}
