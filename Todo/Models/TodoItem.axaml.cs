using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Todo.Models
{
    public class TodoItem
    {
        public string Description { get; set; }
        public bool IsChecked { get; set; }
    }
}