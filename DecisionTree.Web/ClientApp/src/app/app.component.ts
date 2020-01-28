import { Component } from '@angular/core';
import { HttpService } from '../app/shared/http-service';
import { DecisionTreeCondition } from '../app/interfaces/decision-tree-condition';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  constructor(private http: HttpService) { }

  ngOnInit() {
    this.getDecisionTreeCondition();
  }

  private currentCondition: DecisionTreeCondition = <DecisionTreeCondition>{};
  private decisionTreeCondition: DecisionTreeCondition;
  private selectedConditions: Array<any> = [];


  private getDecisionTreeCondition() {
    this.http.get<DecisionTreeCondition>('decisiontreecondition')
      .subscribe(response => {
        this.decisionTreeCondition = response;
        this.changeCondition(this.decisionTreeCondition, null);
      });
  }

  private changeCondition(condition: DecisionTreeCondition, answer: string) {
    this.currentCondition = condition;
    this.saveUserSelections(condition.text, answer);
  }

  private saveUserSelections(conditionText: string, answer: string) {
    this.selectedConditions.push({ conditionText, answer });
  }

  private redecide() {
    this.currentCondition = this.decisionTreeCondition;
    this.selectedConditions = [];
    this.changeCondition(this.decisionTreeCondition, null);
  }
}
