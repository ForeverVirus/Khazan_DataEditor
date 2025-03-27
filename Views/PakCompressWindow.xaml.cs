using System.Resources;
using Khazan_DataEditor.ViewModels;
using DragEventArgs = System.Windows.DragEventArgs;

namespace Khazan_DataEditor.Views;

public partial class PakCompressWindow : System.Windows.Window
{
    public PakCompressWindow()
    {
        InitializeComponent();

        this.Title = MainWindow.s_resourceManager.GetString("Create_Pak");
        this.DragFolder.Text = MainWindow.s_resourceManager.GetString("DragFolder");
    }

    private void Grid_OnDrop(object sender, DragEventArgs e)
    {
        if (DataContext is PakCompressViewModel viewModel)
        {
            try
            {
                // 打印日志，检查参数类型
                Console.WriteLine($"Drop event triggered with parameter type: {e.GetType()}");
                Console.WriteLine($"canExecute {viewModel.DropCommand.CanExecute(e)}");
            
                // 检查命令是否能执行
                if (viewModel.DropCommand.CanExecute(e))
                {
                    Console.WriteLine("DropCommand can be executed.");
                    viewModel.DropCommand.Execute(e);
                }
                else
                {
                    Console.WriteLine("DropCommand cannot be executed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"YYYYY in Grid_OnDrop: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("DataContext is not PakDecompressViewModel.");
        }
    }
}