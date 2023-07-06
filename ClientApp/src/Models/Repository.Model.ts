import { Injectable } from "@angular/core";

import { RiddleSuggestion } from "./RiddleSuggestion.Model";
import { RiddleSuggestionsService } from "src/services/riddle-suggestions.service";

@Injectable()
export class Repository {
    private _riddleSuggestions: RiddleSuggestion[] = [];
  
    constructor( private _riddleSuggestionsService: RiddleSuggestionsService ) {
        console.log("Retreiving from server");
        this._riddleSuggestionsService.getRiddleSuggestions()
            .subscribe( serverRiddleSuggestions => this._riddleSuggestions = serverRiddleSuggestions,
                         () => console.log( "ERROR" ),
                         () => console.log( "Succesfully got riddleSuggestions" ));
    }

    getRiddleSuggestions(): RiddleSuggestion[] {
        return this._riddleSuggestions;
    }

    getRiddleSuggestion(id: number): RiddleSuggestion | undefined {
        return this._riddleSuggestions.find( ( i: RiddleSuggestion ) =>  i.riddleID == id );
    }

    createRiddleSuggestion( riddleSuggestion: RiddleSuggestion ): void {
        this._riddleSuggestionsService.postRiddleSuggestion(riddleSuggestion)
            .subscribe( serverRiddleSuggestion => this._riddleSuggestions.push(serverRiddleSuggestion) );
    }

    updateRiddleSuggestion( riddleSuggestion: RiddleSuggestion ): void {
        this._riddleSuggestionsService.putRiddleSuggestion(riddleSuggestion)
            .subscribe( serverRiddleSuggestion => {
                let i = this._riddleSuggestions.findIndex( ( j: RiddleSuggestion ) => j.riddleID == serverRiddleSuggestion.riddleID );
                this._riddleSuggestions.splice( i, 1, serverRiddleSuggestion);
            } );

    }

    deleteRiddleSuggestion(id: number): void {
        this._riddleSuggestionsService.deleteRiddleSuggestion(id)
        .subscribe( () => {
            let i = this._riddleSuggestions.findIndex( ( j: RiddleSuggestion ) => j.riddleID == id );
            if ( -1 < i )
                this._riddleSuggestions.splice( i, 1 );
        } );
    }
}