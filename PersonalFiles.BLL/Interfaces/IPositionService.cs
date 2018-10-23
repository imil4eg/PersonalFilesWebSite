using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IPositionService
    {
        void CreatePosition(Position position);
        IEnumerable<Position> GetAllPosition();
        Position GetPositionById(int id);
        void RemovePositionById(int id);
        void UpdatePosition(Position position);
    }
}