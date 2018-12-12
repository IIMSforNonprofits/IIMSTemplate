class App extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="App">I am an App container fill me with components.
            </div>

        );
    }
}

ReactDOM.render(<App />, document.getElementById('content'));
