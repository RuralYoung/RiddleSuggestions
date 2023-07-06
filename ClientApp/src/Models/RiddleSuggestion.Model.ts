export class RiddleSuggestion {
    constructor(
        public riddleID?: number,
        public question?: string,
        public answer?: string,
        public hint?: string,
        public rating?: number
    ) {}
}