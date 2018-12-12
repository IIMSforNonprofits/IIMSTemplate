//import { Eric } from "./eric.jsx";

class CommentBox extends React.Component {
    constructor(props) {

    }
    render() {
        return (
            <div className="commentBox">Hello, world! I am a CommentBox.
                <Eric />
                </div>

        );
    }
}

class Eric extends React.Component {

    render() {
        return (
            <div className="Eric">
                Eric is a monster!
            </div>
        )
    }
}

ReactDOM.render(<CommentBox />, document.getElementById('content'));