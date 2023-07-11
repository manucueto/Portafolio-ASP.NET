using Portafolio.Models;
namespace Portafolio.Servicios{
    public interface IRepositorioProyectos{
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos{
        public List<Proyecto> ObtenerProyectos(){
        return new List<Proyecto>(){new Proyecto{
        Titulo = "Amazon",
        Descripcion = "E-Commerce realizado en ASP.NET Core",
        Link = "https://amazon.com",
        ImagenURL = "/img/net.jpeg"
        },
        new Proyecto{
            Titulo = "New York Times",
            Descripcion = "Página de noticias en react",
            Link = "https://nytimes.com",
            ImagenURL = "/img/net.jpeg"
        },
        new Proyecto{
            Titulo = "Reddit",
            Descripcion = "Red social para compartir en comunidades",
            Link = "https://reddit.com",
            ImagenURL = "/img/net.jpeg"
        },
        new Proyecto{
            Titulo = "Steam",
            Descripcion = "Tienda en línea para comprar videojuegos",
            Link = "https://store.steampowered.com",
            ImagenURL = "/img/net.jpeg"
        },
    };


    }
    }
}