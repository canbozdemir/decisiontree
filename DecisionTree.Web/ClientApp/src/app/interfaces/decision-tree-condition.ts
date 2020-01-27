export interface DecisionTreeCondition {
  text: string;
  isLastCondition: boolean;
  yes: DecisionTreeCondition;
  no: DecisionTreeCondition;
}
