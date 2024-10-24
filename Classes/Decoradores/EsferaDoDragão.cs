namespace Guerreiros
{
    class EsferaDoDragao : EsferaDecorator
    {
        public override void aumentarPoderAnel(AnelDecorator anel)
        {
            anel.REFLEC *= 1.3f;
        }
    }
}