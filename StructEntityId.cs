#if !UNITY_6000_4_OR_NEWER

public readonly struct EntityId
{
    private readonly int _value;
    public EntityId(int value) => _value = value;

    public static bool operator ==(EntityId a, EntityId b)  => a._value == b._value;
    public static bool operator !=(EntityId a, EntityId b)  => a._value != b._value;
                                                            
    public static implicit operator EntityId(int value)     => new EntityId(value);
    public static implicit operator int(EntityId id)        => id._value;

    public override string ToString()                       => _value.ToString();
    public override int GetHashCode()                       => _value.GetHashCode();
    public override bool Equals(object obj)                 => obj is EntityId other && _value == other._value;
}
#endif
