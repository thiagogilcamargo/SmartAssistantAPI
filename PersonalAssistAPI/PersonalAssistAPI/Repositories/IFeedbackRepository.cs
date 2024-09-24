using System.Collections.Generic;

public interface IFeedbackRepository
{
    IEnumerable<Feedback> GetAll();
    Feedback GetById(int id);
    Feedback Create(Feedback feedback);
    void Update(Feedback feedback);
    void Delete(int id);
}
