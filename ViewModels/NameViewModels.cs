using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppName.ViewModels;

public partial class NameViewModels : ObservableObject
{


   [ObservableProperty] // damit macht mir das Projekt das selber...
   string _name=string.Empty;

    // die eigenschaft name wird bei der datenbindung verwendet das ViewModel
    // NameViewModel wird in der Code-Behind-Datei
    // Mainpage.xaml via this.BindingContext = new NameViewModel() verbunden.
    // Nur die Eigenschaften werden auf der Oberfläche verwendet
    // dies bedeutet dass _name (=Variable) nicht eingesetzt werden darf nur Name (= Eigenschaft)


    [ObservableProperty]
    string _output = string.Empty;
    // das macht ein kommando aus meiner Methode= nur so kann
    // ich es auf der Oberfläche hernehmen

    // ReylayCommans => Dies bedeutet, dass automatisch ein Command
    // an die Methode angehängt wird. Also ... DoCommand ( es wird ein Command generiert)


    [RelayCommand]
    void Do()
    {
        // Max Muster
       if (!string.IsNullOrEmpty(this.Name))
        {
            var pos = this.Name.IndexOf(' ');
            if (pos != -1) // != ist ungleich
            {
                this.Output = this.Name.Substring(0, pos);
                // es muss die Eigenschaft Output beschrieben verändert werden da ansonsten Set Property
                // nicht aufgerufen wird und die Oberfläche dadurch nicht aktualisiert wird
                // NICHT: OUTPUT VERÄNDERN!!!
            }
        }
    }
}
