public class WeightAdapter : IWeightAdapter
{
    IWeightMachine _weightMachine;
    public WeightAdapter(IWeightMachine weightMachine)
    {
        _weightMachine = weightMachine;
    }
    public double getWeightInKG()
    {
        double weight = _weightMachine.getWeightInPound();

        return weight * .45;
    }
}