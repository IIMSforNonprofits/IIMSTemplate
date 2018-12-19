class Confirmation extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="Confirmation">I am a Confirmation alert to make sure you want to take this action.
            </div>
            // ?Alert or Modal for this component - functionality is to double check you are sure you are sure you want to take this action
        );
    }
}

export Confirmation;