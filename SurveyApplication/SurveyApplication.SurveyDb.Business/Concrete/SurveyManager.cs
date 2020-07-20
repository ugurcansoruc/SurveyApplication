using System.Collections.Generic;
using SurveyApplication.SurveyDb.Business.Abstract;
using SurveyApplication.SurveyDb.DataAccess.Abstract;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.Business.Concrete
{
    public class SurveyManager:ISurveyService
    {
        private readonly ISurveyDal _surveyDal;

        public SurveyManager(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }


        public List<Survey> GetAll()
        {
            return _surveyDal.GetList();
        }

        public Survey GetById(int surveyId)
        {
            return _surveyDal.Get(p => p.Id == surveyId);

        }

        public void Update(Survey survey)
        {
            _surveyDal.Update(survey);
        }

        public void Add(Survey survey)
        {
            _surveyDal.Add(survey);
        }
    }
}
