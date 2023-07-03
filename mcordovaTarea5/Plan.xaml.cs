using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace mcordovaTarea5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plan : ContentPage
    {
        private string Url = "http://192.168.1.4/ws_uisrael/post.php";
        private HttpClient cliente = new HttpClient();
        private ObservableCollection<PlanAlimenticio> post;
        public Plan()
        {
            InitializeComponent();
            ObtenerPlanes();
        }


        private async void ObtenerPlanes()
        {
            var contenido = await cliente.GetStringAsync(Url);
            List<PlanAlimenticio> listaPost = JsonConvert.DeserializeObject<List<PlanAlimenticio>>(contenido);
            post = new ObservableCollection<PlanAlimenticio>(listaPost);
            listaPlan.ItemsSource = post;
        }
    }
}