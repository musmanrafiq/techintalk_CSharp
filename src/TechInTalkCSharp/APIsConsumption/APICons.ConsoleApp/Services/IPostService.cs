using APICons.ConsoleApp.Models;
using Refit;

namespace APICons.ConsoleApp.Services
{
    internal interface IPostService
    {
        [Get("/posts")]
        Task<IApiResponse<List<PostModel>>> GetAll();

        [Post("/posts")]
        Task<IApiResponse> Post([Body] PostModel post);

        [Put("/posts/{id}")]
        Task<IApiResponse> Put(int id, [Body] PostModel model);

        [Delete("/posts/{id}")]
        Task<IApiResponse> Delete(int id);
    }
}
