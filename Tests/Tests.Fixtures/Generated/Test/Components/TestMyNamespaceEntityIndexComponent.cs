//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public My.Namespace.EntityIndexComponent myNamespaceEntityIndex { get { return (My.Namespace.EntityIndexComponent)GetComponent(TestComponentsLookup.MyNamespaceEntityIndex); } }
    public bool hasMyNamespaceEntityIndex { get { return HasComponent(TestComponentsLookup.MyNamespaceEntityIndex); } }

    public void AddMyNamespaceEntityIndex(string newValue) {
        var index = TestComponentsLookup.MyNamespaceEntityIndex;
        var component = CreateComponent<My.Namespace.EntityIndexComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceEntityIndex(string newValue) {
        var index = TestComponentsLookup.MyNamespaceEntityIndex;
        var component = CreateComponent<My.Namespace.EntityIndexComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceEntityIndex() {
        RemoveComponent(TestComponentsLookup.MyNamespaceEntityIndex);
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

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceEntityIndex;

    public static Entitas.IMatcher<TestEntity> MyNamespaceEntityIndex {
        get {
            if(_matcherMyNamespaceEntityIndex == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.MyNamespaceEntityIndex);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherMyNamespaceEntityIndex = matcher;
            }

            return _matcherMyNamespaceEntityIndex;
        }
    }
}
