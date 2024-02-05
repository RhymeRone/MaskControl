using Business.Concrete;
using Entities.Concrete;

PttManager pttManager = new PttManager(new PersonManager());
PttManager foreignerPttManager = new PttManager(new ForeignerManager());

Person trPerson = new Person();
trPerson.FirstName = "İsmail"; // İsim
trPerson.LastName = "Hallaç"; // Soyisim
trPerson.DateOfBirthYear = 1997; // Doğum Yılı
trPerson.NationalIdentity = 191; // Kimlik bilgisi girilecek

pttManager.GiveMask(trPerson);