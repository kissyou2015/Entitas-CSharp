//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public StandardComponent standard { get { return (StandardComponent)GetComponent(TestComponentsLookup.Standard); } }
    public bool hasStandard { get { return HasComponent(TestComponentsLookup.Standard); } }

    public void AddStandard(string newValue) {
        var index = TestComponentsLookup.Standard;
        var component = CreateComponent<StandardComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStandard(string newValue) {
        var index = TestComponentsLookup.Standard;
        var component = CreateComponent<StandardComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStandard() {
        RemoveComponent(TestComponentsLookup.Standard);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherStandard;

    public static Entitas.IMatcher<TestEntity> Standard {
        get {
            if(_matcherStandard == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.Standard);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherStandard = matcher;
            }

            return _matcherStandard;
        }
    }
}
