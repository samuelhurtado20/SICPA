import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Enterprise } from '../models/enterprise';

@Injectable({
  providedIn: 'root'
})
export class EnterpriseService {
  baseUrl = environment.baseUrl;
  apiUrl = 'api/Enterprise'
  constructor(private http: HttpClient) { }

  getById(id: number): Observable<Enterprise>
  {
    const result = this.http.get<Enterprise>(this.baseUrl + this.apiUrl + '/' + id)
    //console.log(result)
    return result;
  }

  getAll(): Observable<Enterprise[]>
  {
    const result = this.http.get<Enterprise[]>(this.baseUrl + this.apiUrl)
    console.log(result)
    return result;
  }

  save(enterprise: Enterprise): Observable<Enterprise>
  {
    const result = this.http.post<Enterprise>(this.baseUrl + this.apiUrl, enterprise)
    console.log(result)
    return result;
  }

  update(enterprise: Enterprise): Observable<Enterprise>
  {
    const result = this.http.put<Enterprise>(this.baseUrl + this.apiUrl, enterprise)
    console.log(result)
    return result;
  }

  delete(id?: string): Observable<any>
  {
    const result = this.http.delete<any>(this.baseUrl + this.apiUrl + '/' + id)
    return result;
  }

}
