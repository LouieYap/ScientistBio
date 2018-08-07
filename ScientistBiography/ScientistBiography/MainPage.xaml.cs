using ScientistBiography.Model;
using ScientistBiography.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScientistBiography
{
    public partial class MainPage : ContentPage
    {

        List<Scientist> scientists;

        public MainPage()
        {
   
            InitializeComponent();
            SetupData();
            
         
        }

        async void OnTapGestureRecognizerTappedEvet(Object sender, TappedEventArgs e)
        {
            var detailPage = new ScientistDetailPage();


            detailPage.BindingContext = scientists[Convert.ToInt32(e.Parameter) - 1] as Scientist;
            await Navigation.PushAsync(detailPage);
        }

        void SetupData()
        {
            scientists = new List<Scientist> ();
            scientists.Add(new Scientist
            {
                Name = "Sir Isaac Newton",
                Description = "Newton was a polymath who made investigations into a whole range of subjects including mathematics," +
                " optics, physics, and astronomy. In his Principia Mathematica, published in 1687, he laid the foundations for classical mechanics, " +
                "explaining the law of gravity and the laws of motion.",
                Year = "1642 - 1726",
                ImageSrc = "isaac_newton.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Louis Pasteur",
                Description = "Pasteur contributed " +
                "greatly towards the advancement of medical sciences developing cures for rabies, anthrax and other infectious diseases. " +
                "Also invented the process of pasteurisation to make milk safer to drink. He probably saved more lives than any other person.",
                Year = "1822 – 1895",
                ImageSrc = "louis_pasteur.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Galileo",
                Description = "Creating one of the first modern telescopes, Galileo revolutionised our understanding of the world, successfully proving the Earth " +
                "revolves around the Sun and not the other way around. His work Two New Sciences laid the groundwork for the science of Kinetics and strength of materials.",
                Year = "1564 – 1642",
                ImageSrc = "galileo.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Marie Curie",
                Description = "Polish physicist and chemist. Discovered radiation and helped to apply it in the field of X-ray. " +
                "She won the Nobel Prize in both Chemistry and Physics.",
                Year = "1867 – 1934",
                ImageSrc = "marie_curie.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Albert Einstein",
                Description = "Revolutionised modern physics with his general theory of relativity. He won the Nobel Prize in Physics (1921) for his discovery of the Photoelectric effect, " +
                "which formed the basis of Quantum Theory.",
                Year = "1879 – 1955",
                ImageSrc = "albert_einstein.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Charles Darwin",
                Description = "Darwin developed his theory of evolution against a backdrop of disbelief and scepticism. " +
                "He collected evidence over 20 years and published his conclusions in On the Origin of Species (1859).",
                Year = "1809 – 1882",
                ImageSrc = "charles_darwin.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Otto Hahn",
                Description = "Hahn was a German chemist who discovered nuclear fission (1939). He was a pioneering scientist in the field of radiochemistry and discovered radioactive elements " +
                "and nuclear isomerism (1921). He was awarded the Nobel Prize for Chemistry in 1944.",
                Year = "1879–1968",
                ImageSrc = "otto_hahn.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Nikola Tesla",
                Description = "Tesla worked on electromagnetism and AC current. He is credited with many patents from electricity to " +
                "radio transmission and played a key role in the development of modern electricity.",
                Year = "1856 – 1943",
                ImageSrc = "nikola_tesla.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "James Clerk Maxwell",
                Description = "Maxwell made great strides in understanding electromagnetism. His research in electricity and kinetics laid the foundation for quantum physics. " +
                "Einstein said of Maxwell, “The work of James Clerk Maxwell changed the world forever.",
                Year = "1831 - 1879",
                ImageSrc = "james_clerk_maxwell.jpg"
            });
            scientists.Add(new Scientist
            {
                Name = "Aristotle",
                Description = "A great early Greek scientist who made many types of research in the natural sciences including botany, zoology, " +
                "physics, astronomy, chemistry, meteorology and geometry.",
                Year = "384 BCE–322 BCE",
                ImageSrc = "aristotle.jpg"
            });
        }
    }
}
