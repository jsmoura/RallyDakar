using Microsoft.VisualStudio.TestTools.UnitTesting;
using RallyDakar.Dominio.Entidades;
using System.Linq;

namespace RallyDakar.Dominio.Testes.Temporadas
{
    [TestClass]
    public class AdicionarDuasEquipesTeste
    {

        Temporada temporada;
        Equipe equipe1;
        Equipe equipe2;
        Equipe equipe3;

        [TestInitialize]
        public void Initialize()
        {
            temporada = new Temporada();
            temporada.Id = 1;
            temporada.Nome = "Temporada 2020";

            equipe1 = new Equipe();
            equipe1.Id = 1;
            equipe1.Nome = "Equipe Teste 1";

            equipe2 = new Equipe();
            equipe2.Id = 2;
            equipe2.Nome = "Equipe Teste 2";

            equipe3 = new Equipe();
            equipe3.Id = 3;
            equipe3.Nome = "Equipe Teste 3";

            temporada.AdicionarEquipe(equipe1);
            temporada.AdicionarEquipe(equipe2);
            //temporada.AdicionarEquipe(equipe3);
        }

        [TestMethod]
        public void DuasEquipesAdicionadasCorretamente()
        {
            Assert.IsTrue(temporada.Equipes.Count() == 2);
        }
    }
}
