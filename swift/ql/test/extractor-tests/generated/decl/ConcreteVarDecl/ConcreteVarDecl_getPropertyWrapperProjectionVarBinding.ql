// generated by codegen/codegen.py
import codeql.swift.elements
import TestUtils

from ConcreteVarDecl x
where toBeTested(x) and not x.isUnknown()
select x, x.getPropertyWrapperProjectionVarBinding()