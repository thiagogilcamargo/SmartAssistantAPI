using System.Collections.Generic;

public interface IFeedbackService
{
    IEnumerable<Feedback> GetAll();
    Feedback GetById(int id);
    Feedback Create(Feedback feedback);
    void Update(Feedback feedback);
    void Delete(int id);
}

public class FeedbackService : IFeedbackService
{
    private readonly IFeedbackRepository _repository;

    public FeedbackService(IFeedbackRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Feedback> GetAll() => _repository.GetAll();

    public Feedback GetById(int id) => _repository.GetById(id);

    public Feedback Create(Feedback feedback) => _repository.Create(feedback);

    public void Update(Feedback feedback) => _repository.Update(feedback);

    public void Delete(int id) => _repository.Delete(id);
}
