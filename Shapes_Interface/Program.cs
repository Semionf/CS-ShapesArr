namespace Shapes_Interface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static IShape highestKodkodimCount(IShape obj1, IShape obj2)
        {
           if(obj1.KodkodimCount() > obj2.KodkodimCount())
            {
                return obj1;
            }
            else
            {
                return obj2;
            }
        }
    }
}