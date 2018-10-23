using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public class PositionService : IPositionService
    {
        #region Private Fields

        /// <summary>
        /// Access to database
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with access to database value as parameter
        /// </summary>
        public PositionService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns all positions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> GetAllPosition()
        {
            return this._unitOfWork.Positions.GetAll();
        }

        /// <summary>
        /// Returns the position with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Position GetPositionById(int id)
        {
            return this._unitOfWork.Positions.Get(id);
        }

        /// <summary>
        /// Creates a new position
        /// </summary>
        /// <param name="position"></param>
        public void CreatePosition(Position position)
        {
            this._unitOfWork.Positions.Create(position);
        }

        /// <summary>
        /// Removes the position with specific id
        /// </summary>
        /// <param name="id"></param>
        public void RemovePositionById(int id)
        {
            this._unitOfWork.Positions.Delete(id);
        }

        /// <summary>
        /// Updates a position
        /// </summary>
        /// <param name="position"></param>
        public void UpdatePosition(Position position)
        {
            this._unitOfWork.Positions.Update(position);
        }

        #endregion
    }
}
