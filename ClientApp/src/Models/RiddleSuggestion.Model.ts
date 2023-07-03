export class RiddleSuggestion {
    constructor(
        public riddleId?: number,
        public question?: string,
        public answer?: string,
        public hint?: string,
        public rating?: number
    ) {}
}