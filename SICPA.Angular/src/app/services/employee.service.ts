import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})

export class EmployeeService {
  baseUrl = environment.baseUrl;
  apiUrl = 'api/Employee'
  constructor(private http: HttpClient) { }

  getById(id: number): Observable<Employee>
  {
    return this.http.get<Employee>(this.baseUrl + this.apiUrl + '/' + id)
  }

  getAll(): Observable<Employee[]>
  {
    return this.http.get<Employee[]>(this.baseUrl + this.apiUrl)
  }

  save(Employee: Employee): Observable<Employee>
  {
    return this.http.post<Employee>(this.baseUrl + this.apiUrl, Employee)
  }

  update(Employee: Employee): Observable<Employee>
  {
    return this.http.put<Employee>(this.baseUrl + this.apiUrl, Employee)
  }

  delete(id?: string): Observable<any>
  {
    return this.http.delete<any>(this.baseUrl + this.apiUrl + '/' + id)
  }

}
