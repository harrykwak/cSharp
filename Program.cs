using System;

namespace workspace
{
    class Program
    {
        static void Main()
        {
            workspace.Hello hello = new workspace.Hello();
            workspace.Ex001 ex001 = new workspace.Ex001();
            workspace.Ex002 ex002 = new workspace.Ex002();
            workspace.Ex006 ex006 = new workspace.Ex006();
            workspace.Score score = new workspace.Score();
            workspace.Ex009 ex009 = new workspace.Ex009();

            score.Run();

        }

    }
}
