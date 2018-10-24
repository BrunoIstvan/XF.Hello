using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.App_Code;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{

		public DataBindingPage ()
        {

            InitializeComponent();

            Aluno aluno = InicializarAluno();
            Professor professor = InicializarProfessor();

            painelAluno.BindingContext = aluno;
            painelProfessor.BindingContext = professor;

        }

        private static Professor InicializarProfessor()
        {
            return new Professor()
            {
                Nome = "Professor X",
                Curso = "Xamarin"
            };
        }

        private static Aluno InicializarAluno()
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = "Bruno Istvan Campos Monteiro",
                Email = "bruno.istvan@gmail.com"
            };
        }
    }
}