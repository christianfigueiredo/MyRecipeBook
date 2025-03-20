using MyRecipeBook.Communication.Request;
using MyRecipeBook.Communication.Response;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            //Validar a request
            Validate(request);

            //mapear a request em uma entidade

            //criptografia da senha

            //salvar no banco de dados

            return new ResponseRegisterUserJson
            {
                Name = request.Name,
                Email = request.Email,
            };
        }

        private void Validate(RequestRegisterUserJson request)
        {
           var validator = new RegisterUserValidator();

           validator.Validate(request);

        }
    }
}
