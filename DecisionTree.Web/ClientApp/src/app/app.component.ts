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


  private getDecisionTreeCondition() {
    this.http.get<DecisionTreeCondition>('decisiontreecondition')
      .subscribe(response => {
        this.decisionTreeCondition = response;
        this.changeCondition(this.decisionTreeCondition)
      });
  }

  private changeCondition(condition: DecisionTreeCondition) {
    this.currentCondition = condition;
  }

  private redecide() {
    this.currentCondition = this.decisionTreeCondition;
  }
}
