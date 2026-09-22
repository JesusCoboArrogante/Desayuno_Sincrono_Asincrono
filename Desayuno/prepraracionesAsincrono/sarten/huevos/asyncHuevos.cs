namespace Desayuno.prepraraciones.sarten.huevos;

public class asyncHuevos
{
    public async Task<string>  freirHuevo()
    {
        
        await Task.Delay(300);
        return "Freir huevo";
    }
    
}