//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly My.Namespace.MyNamespaceFlagComponent myNamespaceMyNamespaceFlagComponent = new My.Namespace.MyNamespaceFlagComponent();

    public bool isMyNamespaceMyNamespaceFlag {
        get { return HasComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag); }
        set {
            if(value != isMyNamespaceMyNamespaceFlag) {
                if(value) {
                    AddComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag, myNamespaceMyNamespaceFlagComponent);
                } else {
                    RemoveComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag);
                }
            }
        }
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

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceMyNamespaceFlag;

    public static Entitas.IMatcher<TestEntity> MyNamespaceMyNamespaceFlag {
        get {
            if(_matcherMyNamespaceMyNamespaceFlag == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.MyNamespaceMyNamespaceFlag);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherMyNamespaceMyNamespaceFlag = matcher;
            }

            return _matcherMyNamespaceMyNamespaceFlag;
        }
    }
}
