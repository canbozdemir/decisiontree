import { Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class HttpService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseApiUrl: string) { }

  get<T>(endpoint: string): Observable<T> {
    return this.http.get<T>(`${this.baseApiUrl}${endpoint}`)
      .pipe(catchError(this.handleError));
  }

  private handleError = function (error: Response) {
    return throwError(error);
  };
}
