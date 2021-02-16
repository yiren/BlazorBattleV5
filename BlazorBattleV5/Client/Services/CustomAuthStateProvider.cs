using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
namespace BlazorBattleV5.Client.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public ILocalStorageService localStorageService { get; }
        public CustomAuthStateProvider(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;

        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {   
            var authState =  new AuthenticationState(new ClaimsPrincipal());

            if(await localStorageService.GetItemAsync<bool>("IsAuthenticated"))
            {
                var identity = new ClaimsIdentity(new []{
                    new Claim(ClaimTypes.Name, "Tester1")
                }, "BlazorBattle Auth Test");

                var user = new ClaimsPrincipal(identity);

                authState = new AuthenticationState(user);

                
            }
           
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
            
            return authState;
            
        }
    }
}