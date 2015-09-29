using AngularEducation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularEducationBackend;
using System.Web.Http.Cors;

namespace AngularEducation.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GamesController : AngularEducationController
    {
        [HttpGet]
        public IEnumerable<GameModel> GetGames()
        {
            return AngularEducationUnitOfWorkProvider.UnitOfWork.ReadStatement(p => p.GamePlayerService.ReadQuery(p.GamePlayerService.GetAll()).Select(x => new GameModel(x)));
        }

        public void Insert(GameModel gameModel)
        {
            AngularEducationUnitOfWorkProvider.UnitOfWork.ExcecuteStatement(p => p.GamePlayerService.Insert(new tblGame()
            {
                Name = gameModel.Name
            }));
        }
    }
}
