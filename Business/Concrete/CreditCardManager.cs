using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class CreditCardManager: ICreditCardService
    {
        ICreditCardDal  _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            var result = _creditCardDal.GetAll();
            return new SuccessDataResult<List<CreditCard>>(result);
        }

        public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CardNumber == cardNumber));
        }

        public IDataResult<List<CreditCard>> GetCardsByCustomerId(int id)
        {
            var result = _creditCardDal.GetAll(c => c.CustomerId == id);
            return new SuccessDataResult<List<CreditCard>>(result);
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.Updated);
        }

        public IResult VerifyCard(CreditCard creditCard)
        {
            var result = _creditCardDal.Get(c => c.NameOnTheCard == creditCard.NameOnTheCard && c.CardNumber == creditCard.CardNumber && c.CardCvv == creditCard.CardCvv);
            if (result == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private bool CheckCreditCard(CreditCard card)
        {
            var beforeExist = _creditCardDal.GetAll(c => c.CustomerId == card.CustomerId);

            if (beforeExist.Count > 0)
            {
                var currentCard = _creditCardDal.Get(c => c.CardNumber == card.CardNumber);

                if (currentCard != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
