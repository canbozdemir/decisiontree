import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { BaseApiUrl } from '../../config';

@Injectable()
export class HttpService {
  constructor(private http: HttpClient) { }

  get<T>(endpoint: string): Observable<T> {
    return this.http.get<T>(`${BaseApiUrl}${endpoint}`)
      .pipe(catchError(this.handleError));
  }

  private handleError = function (error: Response) {
    return throwError(error);
  };
}
