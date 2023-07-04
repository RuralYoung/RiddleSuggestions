import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

import { Observable } from 'rxjs';

import { RiddleSuggestion } from 'src/models/RiddleSuggestion.Model';

@Injectable({
  providedIn: 'root'
})
export class RiddleSuggestionsService {
  private riddlesSuggestionsUrl = 'https://localhost:5000/api/RiddleSuggestions'
  constructor( private http: HttpClient ) { }

  // GET: Riddle Suggestions from server
  getRiddleSuggestions(): Observable<RiddleSuggestion[]> {
    return this.http.get<RiddleSuggestion[]>(this.riddlesSuggestionsUrl);
  }

  // GET: Single Riddle Suggestion from server
  getRiddleSuggestion( id: number ): Observable<RiddleSuggestion> {
    return this.http.get<RiddleSuggestion>( `${this.riddlesSuggestionsUrl}/${id}` );
  }

  // POST: Add a Riddle Suggestion
  postRiddleSuggestion( riddleSuggestion: RiddleSuggestion ): Observable<RiddleSuggestion> {
    return this.http.post<RiddleSuggestion>( this.riddlesSuggestionsUrl, riddleSuggestion );
  } 
  
  // PUT: Update a Riddle Suggestion
  putRiddleSuggestion( riddleSuggestion: RiddleSuggestion ): Observable<RiddleSuggestion> {
    return this.http.put<RiddleSuggestion>( `${this.riddlesSuggestionsUrl}/${riddleSuggestion.riddleId}`, riddleSuggestion );
  }

  // DELETE: Delete a Riddle Suggestion
  deleteRiddleSuggestion( id: number ): Observable<RiddleSuggestion> {
    return this.http.delete<RiddleSuggestion>( `${this.riddlesSuggestionsUrl}/${id}` );
  }
}
